function findLargestSumOfDigits (input) {
	var arr = input.split(', ').map(Number);
	var maxSum = 0;
	for (var i = 0; i < arr.length; i++) {
		if (arr[i] < 0) {
			arr[i] *= -1;
		}
		var tmpArr = arr[i].toString().split('').map(Number);
		var tmpMasSum = 0;
		for (var d in tmpArr) {
			tmpMasSum += Math.abs(tmpArr[d]);
		}
		
		console.log(tmpArr);
		console.log(tmpMasSum);
		if (tmpMasSum > maxSum) {
			maxSum = arr[i];
		}
	}

	console.log(maxSum);
}

//findLargestSumOfDigits('5, 10, 15, 111');
findLargestSumOfDigits('33, 44, -99, 0, 20');