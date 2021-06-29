class HotelMenu(type):
    _instances = {}

    def __call__(cls, *args, **kwargs):
        if cls not in cls._instances:
            instance = super().__call__(*args, **kwargs)
            cls._instances[cls] = instance
        return cls._instances[cls]

class Lunch(metaclass=HotelMenu):
    def order_lunch(self):
        print("Your lunch has been ordered successfully")



if __name__ == '__main__':
    myLunch = Lunch()
    yourLunch = Lunch()

    if id(myLunch) == id(yourLunch):
        print("Singleton works, the lunches are similar")
    else:
        print("Singleton failed, our meals are different")

