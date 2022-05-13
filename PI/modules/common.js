const fs = require("fs");


/**
 * Записать в файл результат
 * @param method
 * @param action
 * @param message
 */
const writeToFile = (method, action, message) => {
  const date = new Date();
  const messageOutput = `\n[${date}]: method: ${method}, action: ${action}. Output: ${message}`
  fs.appendFile("./test/result", messageOutput, (err) => {
    if (err) {
      console.log(err);
    }
  });
}

exports.writeToFile = writeToFile;