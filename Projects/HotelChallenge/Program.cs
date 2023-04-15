using System.Globalization;
using System.Text;
using Projects.HotelChallange.Models;

string culture = "pt-BR";
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(culture);


Console.OutputEncoding = Encoding.UTF8;

List<People> guests = new List<People>();

List<Suite> suites = new List<Suite>();
List<string> suiteTypeList = new List<string>();

// To save reservations in Database you will have to save thiis List
  // TODO: Implementar um banco de dados aqui
List<Reservation> reservations = new List<Reservation>();


// ----------- Main functions -----------

void main()
{

  string reservedDays = readAnsware("olá :D \n Quantos dias vai desejar ficar uma reserva?");
  
  int defaultValue = 0;
  var convertedReservedDays = int.TryParse(reservedDays, out defaultValue);
  if( defaultValue == 0) errorHandler("invalidDayNumber");

  Reservation reservation = new Reservation(defaultValue);

  createGuest();

  Console.WriteLine("Lista de Clientes");
  foreach(People guestCheck in guests)
  {
    Console.WriteLine( $"   * {guestCheck.Name} {guestCheck.LastName}");
  }

  finishReservation(reservation);

}

void createGuest()
{
  bool finished = false;
  while(!finished)
  {
    string guestName = readAnsware("Digite o nome do Hóspede sem sobrenome");
    if(guestName == "error" ) errorHandler("nameError");

    string guestLastName = readAnsware("Digite o Sobrenome");
    if(guestLastName == "error" ) errorHandler("lastNameError");

    People guest = new People(guestName, guestLastName);
    guests.Add(guest);

    //* Novo hóspede? 
    string checkNewGuest = readAnsware("Deseja cadastrar um novo hóspede? Sim/Yes ou Não/No");
    if(guestLastName == "error" ) errorHandler("invalidAnsware");
    
    if ( !checkContinue(checkNewGuest) ) finished = true;
    
  }
}


void finishReservation(Reservation reservation)
{

  if(suites.Count == 0 )
  {

    Console.WriteLine("O número de suítes cadastradas no sistema é de 0, prossiga com o cadastramento da suíte...");
    subscribeASuite(reservation);

  }
  else
  {

    string message = $"Deseja cadastrar uma nova suíte? Temos um total de {suites.Count} suítes cadastradas. Sim/Yes/Não/No";
    
    string isNewSuite = readAnsware(message);
    if(isNewSuite == "error" ) errorHandler("invalidAnsware");
    
    if( checkContinue(isNewSuite) ) subscribeASuite(reservation);

  }

  Console.WriteLine("Suites Cadastradas:");

  foreach (var suite in suites)
  {
    Console.WriteLine($"{suite.ID}: Diária: {suite.DiaryValue}, Vagas: {suite.Capacity}");
  }

  string selectedSuiteID = readAnsware("Digite o ID da suíte que você vai selecionar para a estadia");
  if(selectedSuiteID == "error" ) errorHandler("invalidAnsware");

  bool checkId = false;

  int selectedId = 0;
  var checkIfConvertedSelectedSuiteID = int.TryParse(selectedSuiteID, out selectedId);
  if(!checkIfConvertedSelectedSuiteID) errorHandler("invalidAnsware");

  foreach (var suite in suites)
  {
    if(selectedId == suite.ID) 
    {
      checkId = true;
      bindGuestsToSuite(suite, reservation);
    }
    
  }
  if(!checkId) errorHandler("noSuiteMatch");

  // TODO: Implementar um banco de dados aqui
  Console.WriteLine("Reserva Finalizada");

}

void bindGuestsToSuite(Suite suiteSelected, Reservation reservation){
  decimal diaryValue = reservation.diaryCalc(suiteSelected);

  Console.WriteLine($"A suíte ficará no valor de {diaryValue:C}");

  string checkFinishSignIn = readAnsware("Deseja finalizar a reserva? Sim/Yes - Não/No");
  if(checkFinishSignIn == "error" ) errorHandler("invalidAnsware");

  if( !checkContinue( checkFinishSignIn ) ) Environment.Exit(0);

  suiteSelected.subscribeToSuite(guests);

  reservation.SignInSuite(suiteSelected);

}

void subscribeASuite(Reservation reservation)
{
  // First time rendering the CLI, do not have suiteType options, so have to create one
  if(suiteTypeList.Count <= 0)
  {
    createSuiteType(reservation);
  }
  // Already have a Suite type option
  else if( !(suiteTypeList.Count <= 0) )
  {
    Console.WriteLine("Já possuímos no cadastro dos seguintes tipos suítes:");
    
    foreach(var suiteType in suiteTypeList)
    {
      Console.WriteLine($"   *{suiteType}");
    }

    string checkCreateNewTypeOfSuite = readAnsware("Deseja criar um novo tipo de suíte? Sim/Yes - Não/No");
    if(checkCreateNewTypeOfSuite == "error" ) errorHandler("invalidAnsware");
    if( checkContinue(checkCreateNewTypeOfSuite) ) createSuiteType(reservation);
    sigInToSuite();
  }
  // You always have to sign in to a suite
  else sigInToSuite();

}

void sigInToSuite(){

  // You always have to sign in to a suite
  string readSuiteType = readAnsware("Digite o tipo da Suíte");
  readSuiteType = readSuiteType.ToLower();

  bool checkError = false;
  foreach(var suiteType in suiteTypeList){
    if(suiteType == readSuiteType) checkError = true;
  }
  if(readSuiteType == "error" || checkError == false ) errorHandler("invalidAnsware");

  string readCapacity = readAnsware("Digite a capacidade de hóspedes da suíte");
  if(readCapacity == "error" ) errorHandler("invalidAnsware");
  int suiteCapacity = 0;
  var convertedSuiteCapacity = int.TryParse(readCapacity, out suiteCapacity);
  
  string readDiaryValue = readAnsware("Digite o valor diário da suíte (Sem R$)");
  if(readDiaryValue == "error" ) errorHandler("invalidAnsware");
  decimal diaryValue = 0;
  decimal.TryParse(readDiaryValue, out diaryValue);
  
  string readSuiteId = readAnsware("Digite qual será o ID da suíte");
  if(readSuiteId == "error" ) errorHandler("invalidAnsware");
  int suiteId = 0;
  var convertedSuiteID = int.TryParse(readSuiteId, out suiteId);

  Suite newSubscribedSuite = new Suite(readSuiteType, suiteCapacity, diaryValue, suiteId);
  suites.Add(newSubscribedSuite);
}

void createSuiteType(Reservation reservation)
{
  string readNewType = readAnsware("Escreva o novo tipo de suíte:");
    if(readNewType == "error" ) errorHandler("invalidAnsware");

    readNewType = readNewType.ToLower();
    suiteTypeList.Add(readNewType);

    Console.WriteLine("Novo Tipo de Suíte atualizado!!!");
    subscribeASuite(reservation);
}

// ----------- Utils -----------

string readAnsware(string message)
{
  Console.WriteLine("?- " + message);
  var answare = Convert.ToString(Console.ReadLine());
  if(answare == null ) return "error";

  else return answare;
}

bool checkContinue(string answare)
{
  
  switch(answare)
  {
      case "s" :
      case "S" :
      case "Sim" :
      case "sim" :
      case "y" :
      case "Y" :
      case "yes":
      case "Yes":

        return true;

      case "Não":
      case "não":
      case "n":
      case "N":
      case "No":
      case "no":

        return false;
      
      default:
        errorHandler("invalidAnsware");
        return false;
    }

}

void errorHandler(string errorType)
{
  
  switch(errorType)
  {
    case "nameError":
      Console.Error.WriteLine("Por favor, digite um nome válido");
      break;
    case "lastNameError":
      Console.Error.WriteLine("Por favor, digite um sobrenome válido");
      break;
    case "invalidAnsware":
      Console.Error.WriteLine("Por favor, digite uma resposta válida");
      break;
    case "invalidDayNumber":
      Console.Error.WriteLine("Por favor digite uma quantidade válida de dias");
      break;
    case "noSuiteMatch":
      Console.Error.WriteLine("Infelizmente, você um ID que não possuí Suíte");
      break;
  }

  Environment.Exit(0);

}

main();