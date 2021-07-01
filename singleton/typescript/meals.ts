export class Lunch {
	private static takenLunch: Lunch;

	private constructor() {}
	/**
	 * Private constructor method to controll the creation of class instances
	 */

	private static _hasAlreadyTakenLunch(): boolean {
		return Lunch.takenLunch == null;
	}

	static orderLunch(): Lunch {
		if (!Lunch._hasAlreadyTakenLunch) {
			Lunch.takenLunch = new Lunch();
		}
		return Lunch.takenLunch;
	}
}
