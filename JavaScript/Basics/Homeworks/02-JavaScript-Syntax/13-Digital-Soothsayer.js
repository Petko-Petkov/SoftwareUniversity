function soothsayer (years, languages, cities, cars) {
	var year = years[Math.floor(Math.random()*years.length)];
	var language = languages[Math.floor(Math.random()*languages.length)];
	var city = cities[Math.floor(Math.random()*cities.length)];
	var car = cars[Math.floor(Math.random()*cars.length)];

	console.log('You will work for ' + year + ' years on ' + language + '.');
	console.log('Ýou will live in ' + city + ' and drive ' + car + '.');
}

var years = [3, 5, 2, 7 ,9];
var languages = ['Java', 'Python', 'C#', 'Javascript', 'Ruby'];
var cities = ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'];
var cars = ['BMW', 'Audi', 'SAAB', 'Volvo', 'Jaguar'];

soothsayer(years, languages, cities, cars);
soothsayer(years, languages, cities, cars);
soothsayer(years, languages, cities, cars);