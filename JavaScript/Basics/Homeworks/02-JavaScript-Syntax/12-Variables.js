function variablesTypes (name, age, isMale, foods) {
	var favFoods = [];
	for (var i = 0; i < foods.length; i+=1) {
		favFoods[i] = foods[i];
	}

	return 'My name : ' + name + '// type is ' + typeof(name) + "\n" +
	'My age : ' + age + '// type is ' + typeof(age) + '\n' +
	'I am male : ' + isMale + '// type is ' + typeof(isMale) + '\n' +
	'My favourite foods are : ' + favFoods + '//type is' + typeof(favFoods);
}

console.log(variablesTypes('Pesho', 23, true, ['fries', 'banana', 'cake']));