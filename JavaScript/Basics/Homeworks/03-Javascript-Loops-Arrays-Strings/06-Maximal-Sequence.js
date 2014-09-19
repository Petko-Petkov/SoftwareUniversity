function findMaxSequence (input) {
	var tempCounter = 1;
	var maxCounter = 0;
	var lastElement;
	var maxSequence = [];
	if (input.length === 1) {
		return input;
	}
	for (var i = 0; i < input.length-1; i+=1) {
		if (input[i] === input[i+1]) {
			tempCounter+=1;
		} else{
			if (tempCounter>=maxCounter) {
				maxCounter = tempCounter;
				lastElement = input[i];
			}
			tempCounter = 1;
		}
	}

	for (var j =  0; j < maxCounter; j+=1) {
		maxSequence.push(lastElement);
	}

	return maxSequence;
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));