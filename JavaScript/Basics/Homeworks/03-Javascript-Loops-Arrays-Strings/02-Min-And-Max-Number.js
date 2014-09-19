function minAndMaxValue (value) {
	var sorted = value.sort(function(a, b){
		return a-b;
	});

	var min = sorted[0];
	var max = sorted[sorted.length-1];
	console.log('Min -> ' + min);
	console.log('Max -> ' + max);
}

minAndMaxValue([1, 2, 1, 15, 20, 5, 7, 31]);
minAndMaxValue([2, 2, 2, 2, 2]);
minAndMaxValue([500, 1, -23, 0, -300, 28, 35, 12]);