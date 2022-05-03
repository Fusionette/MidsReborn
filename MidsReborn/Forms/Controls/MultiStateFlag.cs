namespace Mids_Reborn.Forms.Controls
{
	public class MultiStateFlag
    {
        public enum Direction
        {
            Up,
            Down
        }

        public enum Mode
        {
            RampUp,
            RampDown,
            Cycle
        }

        public int Current => _value;

        private Direction _direction;
        private readonly Mode _mode;
        private readonly int _maxValue;
        private int _value;

        public MultiStateFlag(int maxValue, int defaultValue, Mode mode, Direction direction = Direction.Up)
        {
            direction = mode switch
            {
                Mode.RampUp => Direction.Up,
                Mode.RampDown => Direction.Down,
                _ => direction
            };

            _maxValue = maxValue;
            _value = defaultValue;
            _direction = direction;
            _mode = mode;
        }

        public void Next()
        {
            switch (_mode)
            {
                case Mode.RampUp:
                    if (++_value > _maxValue)
                    {
                        _value = 0;
                    }

                    break;

                case Mode.RampDown:
                    if (--_value < 0)
                    {
                        _value = _maxValue;
                    }

                    break;

                case Mode.Cycle:
                    _value += _direction == Direction.Up ? 1 : -1;

                    switch (_direction)
                    {
                        case Direction.Up:
                            if (_value > _maxValue)
                            {
                                _direction = Direction.Down;
                                _value = _maxValue - 1;
                            }

                            break;

                        case Direction.Down:
                            if (_value < 0)
                            {
                                _direction = Direction.Up;
                                _value = 1;
                            }

                            break;
                    }

                    break;
            }
        }

        public int GetNext()
        {
            Next();

            return Current;
        }
    }
}