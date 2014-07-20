function selectionSort (value) {
	var tmp;
	var tmp2;

	for (var i = 0; i < value.length - 1; i+=1) {
		tmp = i;

		for (var j = i + 1; j < value.length; j++) {
			if (value[j] < value[tmp]) {
				tmp = j;
			}

			tmp2 = value[tmp];
			value[tmp] = value[i];
			value[i] = tmp2;
		}
	}

	return value;
}

console.log(selectionSort([5, 4, 3, 2, 1]));
console.log(selectionSort([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3, 3]));

