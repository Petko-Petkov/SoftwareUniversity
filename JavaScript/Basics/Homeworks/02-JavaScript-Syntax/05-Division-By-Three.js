function dividerByThree (number) {
	var divider = 0;
	var input = parseInt(number, 10);
	while (input > 0) {
		divider += input%10;
		input = Math.floor(input/10);
	}

	if (divider%3===0) {
		console.log("the number is divided by 3 without remainder");	
	} else{
		console.log("the number is not divided by 3 without remainder");
	}
}

console.log(dividerByThree(12));
console.log(dividerByThree(189));
console.log(dividerByThree(591));