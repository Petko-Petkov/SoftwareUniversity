function primeNumber (number) {
	var isPrime = true;
	var maxDivider = Math.sqrt(number);
	for (var i = 2; i <= maxDivider; i+=1) {
		if (number%i === 0) {
			isPrime = false;
			return isPrime;
		}		
	}
	return isPrime;
}

console.log(primeNumber(7));
console.log(primeNumber(254));
console.log(primeNumber(587));