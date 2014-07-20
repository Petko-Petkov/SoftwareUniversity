function checkDigit (number) {
	var tempNumber = Math.floor(number/100);
	var result = tempNumber%10;

	if (result === 3) {
		return true;		
	} else{
		return false;
	}
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));