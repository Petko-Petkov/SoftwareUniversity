function displayProperties () {
	var properties = [];

	for (var property in document.getElementById('input')) {
		properties.push(property);
	}

	properties.sort();

	for (var id in properties) {

		console.log( properties[id]);
	}
}
