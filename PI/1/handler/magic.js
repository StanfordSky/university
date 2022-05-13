const { alphabet } = require("../config/config.json");
const { stdout } = require("process");
const prompts = require("prompts");
const { cyanBright, greenBright } = require('chalk');
const fs = require("fs");
const { writeToFile } = require("../../modules/common.js")
const { isMagicSquare, generateMagicSquare } = require("../mSquare.js")

const numberLog = cyanBright;
const stringLog = greenBright;

const consoleQuestions = [
  {
    type: "number",
    name: "sizeMatrix",
    message: `Введите размер магического квадрата [${stringLog('Допустимые значения: 3, 5, 7, 9')}]: `,
    validate: value => {
      try{
        return isMagicSquare(generateMagicSquare(value))
      }catch (e) {
        return false
      }
    }
  },
];

const enctryptedMatrix = []


/**
 * Магический квадрат
 * @constructor
 */
async function MagicSquare() {
    String.prototype.chunk = function(size) {
      return [].concat.apply([],
          this.split('').map(function(x,i){ return i%size ? [] : this.slice(i,i+size) }, this)
      )
    }

    String.prototype.replaceAt = function(index, replacement) {
      return this.substr(0, index) + replacement + this.substr(index + replacement.length);
    }

    stdout.write('\n[Зашифровка] Метод: "Магический квадрат."');
    const message = fs.readFileSync("./test/messageMagic").toString();
    const { sizeMatrix } = await prompts(consoleQuestions);

    stdout.write(`
        Исходный текст(messageCesar.txt): ${stringLog(message)}
        Размер каждого блока: ${sizeMatrix}
    `);


  const matrix = generateMagicSquare(sizeMatrix)
  let encryptedMessage = await Encryption(message, matrix, sizeMatrix)
  let decryptedMessage = Decryption(encryptedMessage, matrix, sizeMatrix)

}

async function Encryption(message, matrix, sizeMatrix)
{
  const blockSize = sizeMatrix*sizeMatrix;
  stdout.write(`
      1. Разбиваем строку на блоки заданного ранее размера(${blockSize}):\n`);
  const blocksStr = message.chunk(blockSize)

  while(blocksStr[blocksStr.length - 1].length < blockSize){
    blocksStr[blocksStr.length - 1] += " ";
    stdout.write(`\n\t - Последний блок был дополнен пустым символом.`);
  }
  

  stdout.write(`\n\n`);
  console.table(blocksStr);

  stdout.write(`\n\n2. Формируем магический квадрат:`);
  await outputSquare(matrix)
  const encryptionMessages = []
  let fullTables = matrix.map(function (item) {
    return [...item]
  })
  stdout.write(`\n\n3. Процесс шифрования.\n`);

  for (let blockId = 0; blockId < blocksStr.length; blockId++) {
    let encryptionMessage = '';
    stdout.write(`\nШифрование ${blockId+1} блока:\n`);
    for (let i = 0; i < matrix.length; i++) {
      for (let j = 0; j < matrix.length; j++) {
        let num = matrix[i][j]-1;
        let symb = blocksStr[blockId][num];
        fullTables[i][j] = symb;
        stdout.write(`- символ «${stringLog(symb)}» зашифрован позицией «${numberLog(num+1)}»\n`);
        encryptionMessage += symb
      }
    }
    console.table(fullTables);
    enctryptedMatrix[blockId] = JSON.parse(JSON.stringify(fullTables))
    encryptionMessages.push(encryptionMessage);
  }

  let encryptedMessage = "";
  for (let blockId = 0; blockId < blocksStr.length; blockId++) {
    stdout.write(`\n\t - Результат шифрования ${blockId+1} блока «${stringLog(encryptionMessages[blockId])}»`);
    encryptedMessage += encryptionMessages[blockId];
  }

  writeToFile("magic", "encrypted", encryptedMessage)

  return encryptedMessage;
}


async function Decryption(encryptedMessage, matrix, sizeMatrix)
{
  console.log("\n\n\n\nЗапущен процесс дешифровки:\n")
  console.log("- Ранее сформированные и заполненные символами магические квадраты:\n")
  enctryptedMatrix.forEach(matrix => console.table(matrix))

  const blockSize = sizeMatrix*sizeMatrix;
  const blocksStr = encryptedMessage.chunk(blockSize)
  let decryptionMessages = []

  for (let blockId = 0; blockId < blocksStr.length; blockId++) {
    decryptionMessages[blockId] = []
    for (let i = 0; i < matrix.length; i++) {
      for (let j = 0; j < matrix.length; j++) {
        decryptionMessages[blockId][matrix[i][j]-1] = enctryptedMatrix[blockId][i][j]
      }
    }
    decryptionMessages[blockId] = decryptionMessages[blockId].join("")
    stdout.write(`
        - Строка считанная из матрицы №${blockId}: «${stringLog(decryptionMessages[blockId])}»`)
  }
  const decrypted = decryptionMessages.join("").trim()

  stdout.write(`
  
        Объединив блоки получаем исходную строку: «${stringLog(decrypted)}»
`)

  writeToFile("magic", "decrypted", decrypted)

  return encryptedMessage;

}

async function outputSquare(matrix){
  stdout.write(`\n\nМагический квадрат размером ${numberLog(matrix.length)}:\n`);
  console.table(matrix)
}
  


/**
 * @type {{MagicSquare: ((function(): Promise<void>)|*)}}
 */
module.exports = { MagicSquare };