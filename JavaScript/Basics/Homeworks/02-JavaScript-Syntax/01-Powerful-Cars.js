function convertKWtoHP (value){
	var number = value/0.746;
	return number.toFixed(2);
}

console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));