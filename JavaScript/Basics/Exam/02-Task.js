function solve (input) {

	var matrix = [];
	for (var i= 0; i < input.length; i++) {
		matrix.push(input[i]);
	}



	for (var row = 0; row < matrix.length - 1; row++) {
		var currentRow = matrix[row].split('');
		var nextRow = matrix[row+1].split('');
		var outputFirstRow = currentRow[0];
		var output;
		var currRowArr = [];
		var nextRowArr = [];

		for (var c = 0; c < currentRow.length; c++) {
			currRowArr.push(currentRow[c]);
		}

		for (var j = 0; j < nextRow.length; j++) {
			nextRowArr.push(nextRow[j]);
		}

		for (var ch = 1; ch < nextRow.length; ch++) {

			var currRowInd = currRowArr[ch];
			var nextRowOne = nextRow[ch - 1];
			var nextRowTwo = nextRow[ch];
			var nextRowThree = nextRow[ch+1];

			if (currRowInd === undefined) {
				continue;
			}

			if (row === input.length - 1) {
				if (currRowInd === nextRowOne && currRowInd === nextRowTwo )
					outputFirstRow += '*';
				nextRowArr[ch - 1] = '*';
				nextRowArr[ch] = '*';
				nextRowArr[ch+1] = '*';
			} else {
				outputFirstRow += currentRow[ch];
			}
		} else {
			if ((currRowInd === nextRowOne && currRowInd === nextRowTwo  && currRowInd === nextRowThree)) {
				currRowArr[ch] = '*';
			nextRowArr[ch-1] = '*';
			nextRowArr[ch] = '*';
			nextRowArr[ch+1] = '*';
		}

		output = nextRowArr.join('');
		console.log(output);
	}

	if (row === input.length - 2) {
		console.log(nextRowArr.join(''));
	}

}
}


}

