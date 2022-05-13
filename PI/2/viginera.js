const { writeToFile } = require("../modules/common.js")
const prompts = require("prompts");
const { stdout } = require("process");
const fs = require("fs");
const { cyanBright, greenBright } = require('chalk');

const numberLog = cyanBright;
const stringLog = greenBright;

const config = {
    alphabet: "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
}
const consoleQuestions = [
    {
        type: "text",
        name: "oneKey",
        message: "Введите значение oneKey:",
        validate: oneKey => (oneKey.length > 7) ? true : "Длина первого ключа должна быть не менее 7 символов."
    },
    {
        type: "text",
        name: "twoKey",
        message: "Введите значение twoKey:",
        validate: twoKey => (twoKey.length > 7) ? true : "Длина первого ключа должна быть не менее 7 символов."
    },
    {
        type: "number",
        name: "shiftNumber",
        message: "Введите значение сдвига каждой строки в таблице Вижинера:",
        validate: shiftNumber => (shiftNumber > 0) ? true : "Сдвин не может быть меньше 1."
    },
];

const shift = (str, count) => {
    for (let i = 0; i < count; i++) {
        str = str.charAt(str.length - 1) + str.substr(0, str.length - 1);
    }
    return str;
}

const getVigineraTable = (alph, shiftNumber) => {
    const table = [];
    table[0] = alph;
    for(let i = 1; i < alph.length+1; i++){
        table[i] = (i === 0) ? shift(alph, shiftNumber) : shift(table[i-1], shiftNumber)
    }
    return table;
}

const encryptLoop = (message, alph, stringKey, table) => {
    const numberKeysOne = [], oneEncryptedText = [];
    stringKey.split('').forEach((char, i) => {
        try {
            if((alph.indexOf(char) < 0)){
                throw ("При шифровании в алфавите на найден символ, который имеется в ключ-строке.")
            }
            numberKeysOne[i] = alph.indexOf(char)
        }
        catch (err) {
            return console.log(err);
        }

    })

    message.split('').forEach((char, i) => {
        try {
            if((alph.indexOf(char) < 0)){
                throw ("При шифровании в алфавите на найден символ, который имеется в ключ-строке.")
            }
            oneEncryptedText[i] = table[numberKeysOne[i]][table[0].indexOf(char)];
        }
        catch (err) {
            return console.log(err);
        }
    })
    return [numberKeysOne, oneEncryptedText]
}

const encryption = async (message, oneKey, twoKey, shiftNumber) => {
    const information = [message.split(''), oneKey.split(''), twoKey.split('')];

    const alph = config.alphabet;
    const table = getVigineraTable(alph, shiftNumber).map(str => str.split(''));
    console.log(`Шифруемое сообщение: ${stringLog(message)}`)
    console.log(`Первая ключ-строка: ${stringLog(oneKey)}`)
    console.log(`Вторая ключ-строка: ${stringLog(twoKey)}`)
    console.table(information)
    console.log("Таблица Вижинера: ");
    console.table(table);


    console.log("Первая итерация шифрования:");
    console.log(`Шифруемое сообщение: ${stringLog(message)}`)
    console.log(`Первая ключ-строка: ${stringLog(oneKey)}`)

    const [numberKeysOne, oneEncryptedText] = encryptLoop(message, alph, oneKey, table);
    information[4] = oneEncryptedText;
    console.table([message.split(''), oneKey.split(''), numberKeysOne, oneEncryptedText])

    console.log("Вторая итерация шифрования:");
    const messageTwo = oneEncryptedText.join('')
    console.log(`Шифруемое сообщение: ${stringLog(messageTwo)}`)
    console.log(`Вторая ключ-строка: ${stringLog(twoKey)}`)
    information[5] = twoKey.split('')
    const [numberKeysTwo, twoEncryptedText] = encryptLoop(messageTwo, alph, twoKey, table);
    information[6] = numberKeysTwo;
    information[7] = twoEncryptedText;
    console.table([messageTwo.split(''), twoKey.split(''), numberKeysTwo, twoEncryptedText])

    const encryptedMessage = twoEncryptedText.join('')
    console.log(`Результат двойного шифрования: ${stringLog(encryptedMessage)}`)

    writeToFile('viginera', 'encrypted', encryptedMessage)

    return encryptedMessage;
}

const decryptionLoop = (encryptedMessage, alph, stringKey, table) => {
    let numberKeysOne = [];
    stringKey.split('').forEach((char, i) => {
        try {
            if((alph.indexOf(char) < 0)){
                throw ("При шифровании в алфавите на найден символ, который имеется в ключ-строке.")
            }
            numberKeysOne[i] = alph.indexOf(char)
        }
        catch (err) {
            return console.log(err);
        }

    })

    let oneDectyptedText = [];
    encryptedMessage.split('').forEach((char, i) => {
        oneDectyptedText[i] = alph[table[numberKeysOne[i]].join('').indexOf(char)];
    })

    return [numberKeysOne, oneDectyptedText]
}

const decryption = async (encryptedMessage, oneKey, twoKey, shiftNumber) => {
    const information = [encryptedMessage.split(''), oneKey.split(''), twoKey.split('')];

    const alph = config.alphabet;
    const table = getVigineraTable(alph, shiftNumber).map(str => str.split(''));
    console.log(`Дешифруемое сообщение: ${stringLog(encryptedMessage)}`)
    console.log(`Первая ключ-строка: ${stringLog(oneKey)}`)
    console.log(`Вторая ключ-строка: ${stringLog(twoKey)}`)
    console.table(information)
    console.log("Таблица Вижинера: ");
    console.table(table);


    console.log("Первая итерация дешифрования:");
    console.log(`Шифруемое сообщение: ${stringLog(encryptedMessage)}`)
    console.log(`Вторая ключ-строка: ${stringLog(twoKey)}`)
    const [numberKeysTwo, twoDencryptedText] = decryptionLoop(encryptedMessage, alph, twoKey, table);
    console.table([encryptedMessage.split(''), twoKey.split(''), numberKeysTwo, twoDencryptedText])

    console.log("Вторая итерация дешифрования:");
    console.log(`Шифруемое сообщение: ${stringLog(twoDencryptedText)}`)
    console.log(`Первая ключ-строка: ${stringLog(oneKey)}`)
    let messageOne = twoDencryptedText.join('');
    let [numberKeysOne, oneDencryptedText] = decryptionLoop(messageOne, alph, oneKey, table);
    console.table([messageOne.split(''), oneKey.split(''), numberKeysOne, oneDencryptedText])
    oneDencryptedText = oneDencryptedText.join('');

    console.log(`Результат двойного дешифрования: ${stringLog(oneDencryptedText)}`)
    writeToFile('viginera', 'decrypted', oneDencryptedText)

    return oneDencryptedText;
}

/**
 * Зашифровать и расшифровать русскоязычное сообщение с пробелами и без знаков препинания с помощью шифра Вижинера.
 * Реализовать двойное шифрование с двумя разными числовыми ключами.
 * Длина каждого ключа должна быть не менее 7 символов.
 * @returns {Promise<void>}
 */
const main = async () => {
    console.log("Двойное шифрование методом Вижинера:")
    let { oneKey, twoKey, shiftNumber } = await prompts(consoleQuestions);
    const message = fs.readFileSync("./test/messageViginera").toString();

    oneKey = oneKey.repeat(1000).substring(0, message.length)
    twoKey = twoKey.repeat(1000).substring(0, message.length)

    const encryptedMessage = await encryption(message, oneKey, twoKey, shiftNumber)
    console.log('\n\n')
    await decryption(encryptedMessage, oneKey, twoKey, shiftNumber)
}

// Call start
(async() => {
    await main();
})();