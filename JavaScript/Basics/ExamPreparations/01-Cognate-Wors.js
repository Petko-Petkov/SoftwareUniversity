function solve (input) {
	var arr = input[0].split(/[^A-za-z]+/).filter(Boolean);
	var output = [];

	for (var a = 0; a < arr.length; a++) {
		for (var b = 0; b < arr.length; b++) {
			for (var c = 0; c < arr.length; c++) {
				if (a !== b) {
					if(arr[a] + arr[b] === arr[c]) {
						var word = arr[a] + '|' + arr[b] + '=' + arr[c];
						if (output.indexOf(word) < 0) {
							output.push(word);
						}
					}
				}
			}
		}
	}

	if (output.length === 0) {
		console.log('No');
	} else{
		for (var i = 0; i < output.length; i++) {
			console.log(output[i]);
		}
	}
}

solve(["java..?|basics/*-+=javabasics"]);
solve(['Hi, Hi, Hihi']);
solve(['Uni(lo,.ve=I love SoftUni (Soft)']);
solve(['a a aa a']);
solve(['x a ab b aba a hello+java a b aaaaa']);
solve(['aa bb bbaa']);
solve([	]);