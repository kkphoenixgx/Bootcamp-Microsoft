using System.Text;
using Projects.HotelChallange.Models;

Console.OutputEncoding = Encoding.UTF8;

List<People> guests = new List<People>();
main();

// ----------- Main functions -----------

void main(){

  string reservedDays = readAnsware("olá :D \n Quantos dias vai desejar fazer uma reserva?");
  reservedDays = int.TryParse(reservedDays, out 0 );
  if(reservedDays == 0) errorHandler("invalidDayNumber");
  Reservation reservation = new Reservation(reservedDays);

  createGuest();

    //* Teste
    foreach(People guestCheck in guests){
      Console.WriteLine(guestCheck.Name, guestCheck.LastName);
    }

  subscribeASuite();
}

void createGuest(){
  bool finished = false;
  while(finished)
  {
    string guestName = readAnsware("Digite o nome do Hóspede sem sobrenome");
    if(answare == "error" ) errorHandler("nameError");

    string guestLastName = readAnsware("Digite o nome do Hóspede sem sobrenome");
    if(answare == "error" ) errorHandler("lastNameError");

    People guest = new People(guestName, guestLastName);
    guests.Add(guest);

    //* Novo hóspede? 
    string checkNewGuest = readAnsware("Deseja cadastrar um novo hóspede? Sim/sim/s/S ou Não/não/n/N");
    if(guestLastName == "error" ) errorHandler("invalidAnsware");
    
    if ( !checkContinue(checkNewGuest) ) finished = false;
    
  }
}

void subscribeASuite(){
  //? criar uma suite
  // se o número de suites for 0, não tem como seguir com o cadastro
  string isNewSuite = readAnsware("Deseja cadastrar uma nova suíte?");

  // TODO: Dizer quantas suites existem
}

// ----------- Utils -----------

string readAnsware(string message){
  Console.WriteLine(message);
  var answare = Convert.ToString(Console.ReadLine());
  if(answare == null ) return "error";
  else return answare;
}

bool checkContinue(string answare){
  
  switch(answare){
      case "s" :
      case "S" :
      case "Sim" :
      case "sim" :

        return true;
      
      break;
      case "Não":
      case "não":
      case "n":
      case "N":

        return false;
      
      break;
      default:
        errorHandler("invalidAnsware");
        break;
    }

}

void errorHandler(string errorType){
  
  switch(errorType){
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
  }

  Environment.Exit(0);

}

