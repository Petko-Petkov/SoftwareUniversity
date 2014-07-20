function createArray (value) {
	var arr = [];
	var str = '';
	for (var i = 1; i <= value; i+=1) {
		arr[i] = i*5;
	}
	str = arr.join(', ');
	return str;
}

console.log(createArray(20));