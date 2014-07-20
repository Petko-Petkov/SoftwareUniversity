function findMaxSequence (value) {
	var tempArr = [value[0]];
	var maxArr = [];
	for (var i = 0; i < value.length - 1; i+=1){
		if (value[i] < value[i+1]) {
			tempArr.push(value[i+1]);
		} else{
			if (tempArr.length>maxArr.length) {
				maxArr = tempArr;
			}
			tempArr = [value[i+1]];
		}
	}

	if (tempArr.length>maxArr.length) {
				maxArr = tempArr;
			}

	if (maxArr.length>1) {
		return maxArr;
	} else{
		return 'No';
	}
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));