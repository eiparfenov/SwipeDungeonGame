using Utils.LiveData;
using Zenject;

namespace Player
{
    public class PlayerStats
    {
        private readonly StartPlayerStats _startPlayerStats;
        public MutableLiveData<float> Damage { get; } = new();
        public MutableLiveData<float> Speed { get; } = new();
        public MutableLiveData<float> AttackRate { get; } = new();
        public MutableLiveData<float> MaxHealth { get; } = new();
        public MutableLiveData<float> KnockBack { get; } = new();
        public MutableLiveData<float> Health { get; } = new();
        public MutableLiveData<int> Coins { get; } = new();

        [Inject]
        public PlayerStats(StartPlayerStats startPlayerStats)
        {
            _startPlayerStats = startPlayerStats;
        }

        public void Reset(bool resetHealthAndCoins = false)
        {
            Damage.Value = _startPlayerStats.Damage;
            Speed.Value = _startPlayerStats.Damage;
            AttackRate.Value = _startPlayerStats.Damage;
            MaxHealth.Value = _startPlayerStats.Damage;
            Damage.Value = _startPlayerStats.Damage;
            KnockBack.Value = _startPlayerStats.KnockBack;

            if (resetHealthAndCoins)
            {
                Health.Value = _startPlayerStats.Health;
                Coins.Value = 0;
            }
        }
    }
}