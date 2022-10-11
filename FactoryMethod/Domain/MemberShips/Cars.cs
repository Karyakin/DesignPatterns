using FactoryMethod.Utils.AppConstants;

namespace FactoryMethod.Domain.MemberShips;

internal class BmwX1 : ICars
{
    private readonly string _name;
    private decimal _defaultPrice;
    private bool _blackGlass;
    private bool _cdMultimedia;
    private int _wheelRadius;

    public BmwX1(bool blackGlass, bool cdMultimedia, int wheelRadius)
    {
        _blackGlass = blackGlass;
        _cdMultimedia = cdMultimedia;
        _wheelRadius = wheelRadius;
        _name = "BmwX1";
        _defaultPrice = CarsConst.BmwX1DefaultPrice;
    }

    public string Name => _name;
    public decimal DefaultPrice => _defaultPrice;
    public bool BlackGlass => _blackGlass;
    public bool CdMultimedia => _cdMultimedia;
    public int WheelRadius => _wheelRadius;

    public decimal GetTotalPrice()
    {
        var wheelPrice = _wheelRadius switch
        {
            17 => CarsConst.WheelRadius17,
            19 => CarsConst.WheelRadius19,
            21 => CarsConst.WheelRadius21,
            _ => 0
        };

        var totalPrice = _defaultPrice + wheelPrice + (_blackGlass == true ? CarsConst.BlackGlass : 0) +
                         (_cdMultimedia == true ? CarsConst.CdMultimedia : 0);

        return totalPrice;
    }
}

internal class BmwX3 : ICars
{
    private readonly string _name;
    private decimal _defaultPrice;
    private bool _blackGlass;
    private bool _cdMultimedia;
    private int _wheelRadius;

    public BmwX3(bool blackGlass, bool cdMultimedia, int wheelRadius)
    {
        _blackGlass = blackGlass;
        _cdMultimedia = cdMultimedia;
        _wheelRadius = wheelRadius;
        _name = "BmwX3";
        _defaultPrice = CarsConst.BmwX3DefaultPrice;
    }

    public string Name => _name;
    public decimal DefaultPrice => _defaultPrice;
    public bool BlackGlass => _blackGlass;
    public bool CdMultimedia => _cdMultimedia;
    public int WheelRadius => _wheelRadius;

    public decimal GetTotalPrice()
    {
        var wheelPrice = _wheelRadius switch
        {
            17 => CarsConst.WheelRadius17,
            19 => CarsConst.WheelRadius19,
            21 => CarsConst.WheelRadius21,
            _ => 0
        };

        var totalPrice = _defaultPrice + wheelPrice + (_blackGlass == true ? CarsConst.BlackGlass : 0) +
                         (_cdMultimedia == true ? CarsConst.CdMultimedia : 0);

        return totalPrice;
    }

    internal class BmwX5 : ICars
    {
        private readonly string _name;
        private decimal _defaultPrice;
        private bool _blackGlass;
        private bool _cdMultimedia;
        private int _wheelRadius;

        public BmwX5(bool blackGlass, bool cdMultimedia, int wheelRadius)
        {
            _blackGlass = blackGlass;
            _cdMultimedia = cdMultimedia;
            _wheelRadius = wheelRadius;
            _name = "BmwX5";
            _defaultPrice = CarsConst.BmwX5DefaultPrice;
        }

        public string Name => _name;
        public decimal DefaultPrice => _defaultPrice;
        public bool BlackGlass => _blackGlass;
        public bool CdMultimedia => _cdMultimedia;
        public int WheelRadius => _wheelRadius;

        public decimal GetTotalPrice()
        {
            var wheelPrice = _wheelRadius switch
            {
                17 => CarsConst.WheelRadius17,
                19 => CarsConst.WheelRadius19,
                21 => CarsConst.WheelRadius21,
                _ => 0
            };

            var totalPrice = _defaultPrice + wheelPrice + (_blackGlass == true ? CarsConst.BlackGlass : 0) +
                             (_cdMultimedia == true ? CarsConst.CdMultimedia : 0);

            return totalPrice;
        }
    }
}