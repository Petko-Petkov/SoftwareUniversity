function solve (input) {

	var matrix = [];
	for (var i= 0; i < input.length; i++) {
		matrix.push(input[i]);
	}

	var array = [];

	for (var row = 0; row < matrix.length - 1; row++) {
		var currentRow = matrix[row].split('');
		var nextRow = matrix[row + 1].split('');
		var output = '';
		var firstOut = '';
		var currRowArr = currentRow;
		var nextRowArr = [];
		var prev = matrix[row - 1];

		for (var j = 0; j < nextRow.length; j++) {
			nextRowArr.push(nextRow[j]);
		}

		for (var ch = 1; ch < nextRow.length; ch++) {
			if (currRowArr[ch] === undefined) {
				continue;
			} else if (currRowArr[ch] === nextRow[ch-1] && currRowArr[ch] === nextRow[ch] && currRowArr[ch] === nextRow[ch+1]) {
				currRowArr[ch] = '*';
				nextRowArr[ch-1] = '*';
				nextRowArr[ch] = '*';
				nextRowArr[ch+1] = '*';
			}
		}

		if (row === 0) {
			output = currRowArr.join('') + '\n' + nextRowArr.join('');
			console.log(output);
		} else if (prev.length === 1){
			output = currRowArr.join('');
			console.log(output);
		} else if (currRowArr.length === 1) {
			continue;
		} else {
			output = nextRowArr.join('');
			console.log(output);
		}
	}
}


solve(['ax',
	'xxx',
	'b',
	'bbb',
	'bbbb']);