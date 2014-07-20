function calcSupply (yourAge, yourMaxAge, yourFavFood) {
	var age = parseFloat(yourAge);
	var maxAge = parseFloat(yourMaxAge);
	var favFood = parseFloat(yourFavFood);
	var amount = ((maxAge - age) * favFood)*365;
	return amount;
}

console.log(calcSupply(38, 118, 0.5));
console.log(calcSupply(20, 87, 2));
console.log(calcSupply(16, 102, 1.1));