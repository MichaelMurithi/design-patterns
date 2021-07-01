import { Lunch } from './meals';

//Checks if the same instance of lunch are prepared for the same customer
function prepareLunch() {
	const l1 = Lunch.orderLunch();
	const l2 = Lunch.orderLunch();

	if (l1 === l2) {
		console.log('Singleton works, only one instance of lunch is being created!');
	} else {
		console.log('Singleton failed, different instances of lunch are being created');
	}
}

prepareLunch();
