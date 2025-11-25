const user = process.argv[2];

// BAD: unparameterized SQL query
const query = "SELECT * FROM users WHERE name = '" + user + "'";

console.log(query);
