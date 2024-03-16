import apple from '../assets/apple.svg';
import facebook from '../assets/facebook.svg';
import google from '../assets/google.svg';
import xbox from '../assets/xbox.svg';

interface IButton {
  variant: 'facebook' | 'google' | 'apple' | 'xbox';
}
const Button = ({ variant }: IButton) => {
  return (
    <button className={`button ${variant}`}>
      {variant === 'apple' && <img src={apple} />}
      {variant === 'facebook' && <img src={facebook} />}
      {variant === 'xbox' && <img src={xbox} />}
      {variant === 'google' && <img src={google} />}
    </button>
  );
};

export default Button;
