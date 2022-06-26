// See https://aka.ms/new-console-template for more information
var carOne = new Car();

string nameCarTwo = "carTwo";
decimal costCarTwo = 8000m;
int maxSpeedCarTwo = 220;
var carTwo = new Car(nameCarTwo, costCarTwo, maxSpeedCarTwo);

carOne.ShowInfo(true, true, true);
Console.WriteLine($"{carOne.IsCar}");
Console.WriteLine();
carTwo.ShowInfo(true, true, true);
Console.WriteLine($"{carTwo.IsCar}");
Console.WriteLine();

carOne.SetNameCar = "carOne";
Console.WriteLine($"{carOne.GetNameCar}");
Console.WriteLine();

carTwo.IsCar = true;
Console.WriteLine($"{carTwo.IsCar}");
Console.WriteLine();


public class Car
{
    // Скрытые поля. К ним нет прямого доступа.
    #region private fields

    private string _nameCar;
    private decimal _costCar;
    private int _maxSpeed;

    private bool _isCar;

    #endregion

    // Конструкторы класса
    #region constructors

    public Car()
    {
        _nameCar = "AbstracCar";
        _costCar = 10000m;
        _maxSpeed = 180;
    }

    public Car(string nameCar, decimal costCar, int maxSpeed)
    {
        _nameCar = nameCar;
        _costCar = costCar;
        _maxSpeed = maxSpeed;
    }

    #endregion

    // Методы, доступные извне класса
    #region public methods

    /// <summary>
    /// Вывести информацию по заданным фильтрам
    /// </summary>
    /// <param name="isShowNameCar"></param>
    /// <param name="isShowCostCar"></param>
    /// <param name="isShowMaxSpeed"></param>
    public void ShowInfo(bool isShowNameCar, bool isShowCostCar, bool isShowMaxSpeed)
    {
        if (isShowNameCar)
            Console.WriteLine(GetNameCarValue());

        if (isShowCostCar)
            Console.WriteLine(GetCostCarValue());

        if (isShowMaxSpeed)
            Console.WriteLine(GetMaxSpeedValue());
    }

    #region set info

    /// <summary>
    /// Задать имя автомобиля с помощью модификатора доступа set
    /// </summary>
    /// <param name="nameCar"></param>
    public string SetNameCar 
    { 
        set 
        {
            _nameCar = value;
        }
    }

    /// <summary>
    /// Задать стоимость автомобиля с помощью модификатора доступа set
    /// </summary>
    /// <param name="costCar"></param>
    public decimal SetCostCar
    {
        set
        {
            _costCar = value;
        }
    }

    /// <summary>
    /// Задать максимальную скорость с помощью модификатора доступа set
    /// </summary>
    /// <param name="maxSpeed"></param>
    public int SetMaxSpeed
    {
        set
        {
            _maxSpeed = value;
        }
    }

    #endregion

    #region get info 

    /// <summary>
    /// Задать имя автомобиля с помощью модификатора доступа get
    /// </summary>
    /// <param name="nameCar"></param>
    public string GetNameCar
    {
        get
        {
            return _nameCar;
        }
    }

    /// <summary>
    /// Задать стоимость автомобиля с помощью модификатора доступа get
    /// </summary>
    /// <param name="costCar"></param>
    public decimal GetCostCar
    {
        get
        {
            return _costCar;
        }
    }

    /// <summary>
    /// Получить максимальную скорость с помощью модификатора доступа get
    /// </summary>
    /// <param name="maxSpeed"></param>
    public int GetMaxSpeed
    {
        get
        {
            return _maxSpeed;
        }
    }

    #endregion

    #region set and get info

    /// <summary>
    /// Задать или изменить значение переменной с помощью модификаторов доступа get и set
    /// </summary>
    public bool IsCar
    {
        get { return _isCar; }
        set { _isCar = value; }
    }

    #endregion

    #endregion

    // Методы, доступные только в классе
    #region private methods

    /// <summary>
    /// Получить имя автомобиля
    /// </summary>
    /// <returns></returns>
    private string GetNameCarValue() => _nameCar;

    /// <summary>
    /// Получить стоимость автомобиля
    /// </summary>
    /// <returns></returns>
    private decimal GetCostCarValue() => _costCar;

    /// <summary>
    /// Получить максимальную скорость автомобиля
    /// </summary>
    /// <returns></returns>
    private int GetMaxSpeedValue() => _maxSpeed;

    #endregion
}