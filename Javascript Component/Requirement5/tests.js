
// to run the tests, execute the following in a command line
// (nodejs and npm are required to be installed on the system)
// > npm run test
var assert = require('assert');

require('./stringExtensions.js');

assert.equal("hang the dj".startsWith("hang"), true);
assert.equal("hang the dj".startsWith("Hang"), false);
assert.equal("hang the dj".startsWith("I've got room for rent"), false);
assert.equal("hang the dj".startsWith(""), true);
assert.equal("hang the dj".startsWith("hang the"), true);
assert.equal("hang the dj".startsWith("han"), true);
assert.equal("hang the dj".startsWith("hang t"), true);
assert.equal("hang the dj".startsWith(42), false);
assert.equal("hang the dj".startsWith({first:"Johny"}), false);


assert.equal("hang the dj".endsWith("dj"), true);
assert.equal("hang the dj".endsWith("panic on the streets"), false);
assert.equal("hang the dj".endsWith(""), true);
assert.equal("hang the dj".endsWith("the dj"), true);
assert.equal("hang the dj".endsWith("e dj"), true);
assert.equal("hang the dj".endsWith("j"), true);
assert.equal("hang the dj".endsWith(42), false);
assert.equal("hang the dj".endsWith({first:"Johny"}), false);

// other tests
assert.equal("hang".startsWith("hang"), true);
assert.equal("hang".startsWith("hang "), false);
assert.equal("hang".startsWith("ang"), false);

assert.throws( function() { String.prototype.startsWith.call(undefined); }, TypeError);
assert.throws( function() { String.prototype.startsWith.call(undefined, "a"); }, TypeError);
assert.throws( function() { String.prototype.startsWith.call(null); }, TypeError);
assert.throws( function() { String.prototype.startsWith.call(null, "a"); }, TypeError);

assert.throws( function() { String.prototype.startsWith.apply(undefined); }, TypeError);
assert.throws( function() { String.prototype.startsWith.apply(undefined, ["a"]); }, TypeError);
assert.throws( function() { String.prototype.startsWith.apply(null); }, TypeError);
assert.throws( function() { String.prototype.startsWith.apply(null, ["a"]); }, TypeError);

assert.equal("hang".endsWith("hang"), true);
assert.equal("hang".endsWith(" hang"), false);
assert.equal("hang".endsWith("han"), false);

assert.throws( function() { String.prototype.endsWith.call(undefined); }, TypeError);
assert.throws( function() { String.prototype.endsWith.call(undefined, "a"); }, TypeError);
assert.throws( function() { String.prototype.endsWith.call(null); }, TypeError);
assert.throws( function() { String.prototype.endsWith.call(null, "a"); }, TypeError);

assert.throws( function() { String.prototype.endsWith.apply(undefined); }, TypeError);
assert.throws( function() { String.prototype.endsWith.apply(undefined, ["a"]); }, TypeError);
assert.throws( function() { String.prototype.endsWith.apply(null); }, TypeError);
assert.throws( function() { String.prototype.endsWith.apply(null, ["a"]); }, TypeError);