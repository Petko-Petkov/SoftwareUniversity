function printNumber (number) {
	var result = '';

	if (number < 0){
			result += 'no';
		}

	for (var i = 1; i <= number; i+=1) {
		if ((i % 4 === 0) || (i % 5 === 0)) {
			result += ('');
		} else{
			result += (i) + ' ';
		}
	}

	return result;
}

console.log(printNumber(20));
console.log(printNumber(-5));
console.log(printNumber(13));