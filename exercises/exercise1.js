function logMessage(message, exercise){
  
  switch (exercise) {
    case 1:
      
      //  console.log(message)
        break;
      
      case 2:
      //  console.log(message)
        break;
      case 3:
        // console.log(message)
      break;
      case 4:
        console.log(message)
      break;
      default:
        console.log(message)

  }
}

/*
  Desafio: faça um programa para calcular o valor de uma viagem

  Você terá 3 variáveis:
    - Preço do combustível
    - Gasto médio de combustível do carro por km
    - Distância em km

  Imprima no console o valor.
*/

let precoDoCombsutivel
const tipoDeCombustivel = 'álcool'

if (tipoDeCombustivel === 'álcool') precoDoCombsutivel = 5.79;
else precoDoCombsutivel = 6.66

let KmPorL = 10;
let distanciaKm = 100;

let litrosConsumidos = distanciaKm / KmPorL;
let result = litrosConsumidos * precoDoCombsutivel;

logMessage(result.toFixed(2), 1)

// ----------- Lista de Exercício -----------

/* --------- Exercício 1 - Média Aritmética --------- */

let notaUm = 2
let notaDois = 2
let notaTres = 2

let media = ( (notaUm + notaDois + notaTres ) /3)

if(media < 5){
  logMessage(`Sua nota foi ${media.toFixed(1)}, sinto te dizer, contudo, você foi reprovado`, 2)
}
else if(media >= 5 && media < 7){
  logMessage(`Sua nota foi ${media.toFixed(1)}, infelizmente está de recuperação`, 2);
}
else if(media > 7){
  logMessage(`Sua nota foi ${media.toFixed(1)}, parabéns pela nota, você passou!!!`, 2)
}
else throw new Error('Bug in Exercise 1')

/* --------- Exercício 2 - Imc --------- */

let altura = 1.70
let peso = 54

let IMC = peso / ( Math.pow(altura, 2) )
IMC = IMC.toFixed(2)

//? Eu usei aqui if e não switch por fins didáticos, pela aula da DIO

if(IMC < 18.5) logMessage('Está abaixo do peso', 3) 
else if(IMC >= 18.5 && IMC < 25) logMessage('Está com o peso normal', 3)
else if(IMC >= 25 && IMC < 30) logMessage('Está com sobrepeso', 3)
else if(IMC >= 30 && IMC < 40) logMessage('O senhor está com Obesidade', 3)
else if(IMC >= 40) {
  logMessage('O senhor está com obesidade grave, procure um médico com urgência', 3)
}
else throw new Error('Bug in IMC')

/* --------- Exercise 4 - Tipo de pagamento --------- */

let tipoDePagamento = 'crédito'
let precoDoProduto = 10

switch (tipoDePagamento) {
  case 'débito':
    precoDoProduto -= precoDoProduto * 0.1

    executarPagamento(precoDoProduto)
    break;
  case 'débito':
  case 'dinheiro':
  case 'pix':
    precoDoProduto -= precoDoProduto * 0.15

    executarPagamento(precoDoProduto)
    break;
  case 'crédito':
    let parcelas = 5

    if (parcelas > 2) precoDoProduto +=  precoDoProduto * 0.1

    executarPagamento(precoDoProduto)
    break;

  default:
    console.error('infelizmente não aceitamos esse tipo de pagamento');
    break;
}

function executarPagamento(value){
  logMessage(`pagamento realizado no valor de ${value}`, 4)
}

