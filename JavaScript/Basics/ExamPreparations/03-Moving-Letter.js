function solve (input) {
	var words = input[0].split(' ');
	var longest = 0;

	for (var y = 0; y < words.length; y++) {
		words[y] = words[y].split('');
	}

	for (var k = 0; k < words.length - 1; k++) {
		
		if (words[k].length > longest) {
			longest = words[k].length;
		}
	}

	for (var lett = 0; lett < words.length; lett++) {


		for (var j = longest -1; j >=  0; j--) {
			
		}
	}
}