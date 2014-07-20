function checkBrackets (value) {
	var brackets = 0;

	for (var i = 0; i < value.length; i++) {
		if (value[i] === '(') {
			brackets += 1;
		} else if (value[i] === ')') {
			brackets -= 1;
		} else {
			continue;
		}

		if (brackets < 0) {
			break;
		}
	}

	if (brackets === 0) {
		return 'correct';
	} else{
		return 'incorrect';
	}
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));