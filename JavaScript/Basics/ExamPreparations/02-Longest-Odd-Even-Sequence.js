function solve (input) {
	var numbers = input[0].split(/[ ()]+/);
	numbers = numbers.filter(Boolean).map(Number);

	var counter = 1;
	var maxCounter = 1;
	var zeroArr = [];

	//check for leading zeroes and pushing them to an array with the first non-zero digit

	for (var j = 0; j < numbers.length; j++) {
		if (numbers[j] === 0) {
			zeroArr.push(numbers[j]);
		} else{
			if (zeroArr.length > 0) {
				zeroArr.push(numbers[j]);
				break;
			} else{
				break;
			}
		}
	}

	//reversing the array

	zeroArr = reverseArray(zeroArr);

	//making the zeroes of sequence of odd even numbers

	for (var m = 0; m < zeroArr.length - 1; m++) {
		zeroArr[m+1] = zeroArr[m] + 1;
	}

	//reversing again the array and replacing the zeroes in the input array

	zeroArr = reverseArray(zeroArr);

	for (var p = 0; p < zeroArr.length; p++) {
		numbers[p] = zeroArr[p];
	}

	//main logic

	for (var i = 0; i < numbers.length-1; i++) {
		var isOddCurrent = numbers[i] % 2;
		var isOddNext = numbers[i+1] %2;



		if (isOddCurrent !== isOddNext || numbers[i + 1] === 0) {
			if (numbers[i + 1] === 0 && numbers[i] !== 0) {
				numbers[i + 1] = numbers[1] + 1;
			}
			counter+=1;
		} else{
			if (counter > maxCounter) {
				maxCounter = counter;
			}
			counter = 1;
		}
	}

	if (counter + zeroArr.length> maxCounter) {
		maxCounter = counter;
	}

	//reversing an array function

	function reverseArray (input) {
		var reversedArr = [];

		for (var index = 0; index < input.length; index++) {
			var ind = input.length - index - 1;

			reversedArr.push(input[ind]);
		}

		return reversedArr;
	}


	console.log(maxCounter);
}