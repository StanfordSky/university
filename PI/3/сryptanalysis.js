const { CaesarAffineSubstitutionSystemNotDecrypted } = require('../1/handler/cesar')
const prompts = require("prompts");
const fs = require("fs");



const main = async () => {
    const encryprtedMessage = await CaesarAffineSubstitutionSystemNotDecrypted();
}

// Call start
(async() => {
    await main();
})();