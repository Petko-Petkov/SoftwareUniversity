function replaceSpaces (value) {
	var replace = ' ';
	var rgx = new RegExp(replace, 'g');
	return value.replace(rgx, '');
}

console.log(replaceSpaces('But you were living in another world tryin\' to get your message through'));