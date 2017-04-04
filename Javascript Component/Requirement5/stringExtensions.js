
// Assume we only have to deal with ASCII characters

(function() {

'use strict';
String.prototype.startsWith = function(value) {
    // make sure our method gets called instead of the default one
    console.log("the new startsWith", this, value);
    
    if (this == null || this == undefined) {
        throw TypeError();
    }

    var thisString = String(this);
    var valueString = String(value);

    if (valueString == "") {
        return true;
    }

    var thisLength = thisString.length;
    var valueLength = valueString.length;

    if(thisLength < valueLength) {
        return false;
    }

    var index = 0;

    while( index < valueLength) {
        if (thisString.charAt(index) != valueString.charAt(index)) {
            return false;
        }
        index++;
    }

    return true;
};

String.prototype.endsWith = function(value) {
    // make sure our method gets called instead of the default one
    console.log("the new endsWith", this, value);
    
    if (this == null) {
        throw TypeError();
    }

    var thisString = String(this);
    var valueString = String(value);

    if (valueString == "") {
        return true;
    }

    var thisLength = thisString.length;
    var valueLength = valueString.length;

    if(thisLength < valueLength) {
        return false;
    }

    var index = 0;

    while(index < valueLength) {
        if (thisString.charAt( thisLength - index - 1)
            != valueString.charAt( valueLength - index - 1)) {
            
            return false;
        }
        index++;
    }

    return true;
};
}());