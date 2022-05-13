const { alphabet } = require("../config/config.json");
const { stdout } = require("process");
const prompts = require("prompts");
const { cyanBright, greenBright } = require('chalk');
const fs = require("fs");
const { writeToFile } = require("../../modules/common.js")

const numberLog = cyanBright;
const stringLog = greenBright;

const alphabetArray = alphabet.split('');
const M = alphabet.length;
const consoleQuestions = [
  {
    type: "number",
    name: "A",
    message: "Введите значения A:",
    validate: (A) => validateNumberA(A, M)
  },
  {
    type: "number",
    name: "K",
    message: "Введите значения K:",
  },
];

/**
 * Аффинная система подстановок Цезаря
 * @constructor
 */
async function CaesarAffineSubstitutionSystem() {
  stdout.write('\nМетод: "Аффинная система подстановок Цезаря."');

  const message = fs.readFileSync("./test/messageCesar").toString();
  const { A, K } = await prompts(consoleQuestions);

  stdout.write(`
      Значение A = ${numberLog(A)};
      Значение K = ${numberLog(K)};
  `);

  stdout.write(`
      Алфавит: ${stringLog(alphabet)}
      Исходный текст(messageCesar.txt): ${stringLog(message)}
  `);

  const encryptedMessage = await Encryption(alphabetArray, message, A, K, M);
  const decryptedMessage = await Decryption(alphabetArray, encryptedMessage, A, K, M);

  writeToFile("cesar", "encrypted", encryptedMessage);
  writeToFile("cesar", "dencrypted", decryptedMessage);

  stdout.write(`\n
      Результат шифрования: ${stringLog(encryptedMessage)}
      Результат дешифрования: ${stringLog(decryptedMessage)}
  `);
}

async function CaesarAffineSubstitutionSystemNotDecrypted() {
  stdout.write('\nШифрование методом: "Аффинная система подстановок Цезаря."');

  const message = fs.readFileSync("./test/messageCesar").toString();
  const { A, K } = await prompts(consoleQuestions);

  stdout.write(`
      Значение A = ${numberLog(A)};
      Значение K = ${numberLog(K)};
  `);

  stdout.write(`
      Алфавит: ${stringLog(alphabet)}
      Исходный текст(messageCesar.txt): ${stringLog(message)}
  `);

  const encryptedMessage = await Encryption(alphabetArray, message, A, K, M);

  writeToFile("cesar", "encrypted", encryptedMessage);

  stdout.write(`\n
      Результат шифрования: ${stringLog(encryptedMessage)}
  `);

  return encryptedMessage;
}

/**
 * Функция зашифровки.
 * @param alphabetArray
 * @param message
 * @param A
 * @param K
 * @param M
 * @returns {string}
 * @constructor
 */
async function Encryption(alphabetArray, message, A, K, M) {
  stdout.write("\n[Encryption]:");
  const encryptedMessage = [];

  message.split("").map((value, index) => {
    const X = alphabet.indexOf(value);
    if (X === -1) {
      encryptedMessage.push(value);
      return;
    }

    const I = (A * X + K) % M;
    encryptedMessage.push(alphabetArray[I]);
    stdout.write(`\n${index}: I = (${numberLog(A)} * ${numberLog(X)} + ${numberLog(K)}) % ${numberLog(M)}} = ${numberLog(I)}`);
  });

  return encryptedMessage.join("");
}

/**
 *
 * @param alphabetArray
 * @param encryptedMessage
 * @param A
 * @param K
 * @param M
 * @returns {string}
 * @constructor
 */
async function Decryption(alphabetArray, encryptedMessage, A, K, M) {
  stdout.write("\n\n[Decryption]:");
  const dencryptedMessage = [];

  encryptedMessage.split("").map((value, index) => {
    const GCDEX = gcdex(A, M);
    const alphabetPosition = alphabet.indexOf(value);
    const J = (GCDEX * (alphabetPosition + M - K)) % M;

    stdout.write(
      `\n${index}: J = (${numberLog(GCDEX)}) * (${numberLog(alphabetPosition)} + ${numberLog(M)} - ${numberLog(K)}) % ${numberLog(M)} = ${numberLog(J)}`
    );

    dencryptedMessage.push(alphabetArray[J]);
  });

  return dencryptedMessage.join("");
}

/**
 * Проверить, является ли два числа взаимно простыми
 * @param a
 * @param b
 * @returns {boolean}
 */
function isCoprime(a, b) {
  let num;
  while (b) {
    num = a % b;
    a = b;
    b = num;
  }

  return Math.abs(a) === 1;
}

/**
 * Функция проверяет константу А, считанную из консоли, с мощность алфавита M.
 * @param A - константа считанная из консоли
 * @param M - мощность(размер) алфавита
 * @returns {boolean|string}
 */
function validateNumberA(A, M) {
  const message = `Длина алфавита(${M}) и параметр А(${A}) не являются взаимно простыми числами.`;
  return isCoprime(A, M) ? true : message;
}

/**
 * Реализация расширенного алгоритма Евклида
 * @param a
 * @param m
 * @returns {boolean|number}
 */
function gcdex(a, m) {
  [a, m] = [+a, +m];
  a = ((a % m) + m) % m;

  if (!a || m < 2) {
    return false;
  }

  let [s, b] = [[], m];
  while (b) {
    [a, b] = [b, a % b]
    s.push({ a, b })
  }

  if (a !== 1) {
    return false;
  }

  let [x, y] = [1, 0];
  for (let i = s.length - 2; i >= 0; --i) {
    [x, y] = [y, x - y * Math.floor(s[i].a / s[i].b)];
  }

  return ((y % m) + m) % m;
}

/**
 * @type {{CaesarAffineSubstitutionSystem: ((function(): Promise<void>)|*)}}
 */
module.exports = { CaesarAffineSubstitutionSystem, CaesarAffineSubstitutionSystemNotDecrypted };
