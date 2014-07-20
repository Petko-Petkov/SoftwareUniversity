function findMostFreqNumber (value) {
	var mostFrequent;
	var tmpCount = 0;
	var count = 0;

	for (var i = 0; i < value.length; i+=1) {
		tmpCount = 0;
		for (var j = 0; j < value.length; j++) {
				if (value[i]===value[j]) {
					tmpCount+=1;

					if (tmpCount>count) {
						count = tmpCount;
						mostFrequent = value[i];
					}
				}
			}
	}

	return mostFrequent + ' (' + count + ' times)';
}

console.log(findMostFreqNumber([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNumber([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));