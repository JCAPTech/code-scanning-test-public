const { exec } = require("child_process");

// BAD: unsanitized user input passed directly to exec()
const userInput = process.argv[2];

exec(userInput, (err, stdout, stderr) => {
    console.log(stdout);
});
