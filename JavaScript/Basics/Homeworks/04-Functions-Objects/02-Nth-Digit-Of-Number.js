function findNthDigit (input) {
	var counter = input[0];
	var arr = input[1].split('');
	var output = [];

	for (var i = 0; i < arr.length; i++) {
		if (parseInt(arr[i])) {
			output.push(arr[i]);
		}
	}

	if (counter > output.length) {
		console.log('The number doesn\'t have ' + counter + ' digits');
	} else {
		console.log(output[output.length - counter]);
	}
}

findNthDigit(['1', '6']);
findNthDigit(['2', '-55']);
findNthDigit(['6', '923456']);
findNthDigit(['3', '1451.78']);
findNthDigit(['6', '888.88']);