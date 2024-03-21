import { useState } from 'react';
import Arrow from '../assets/arrow.svg?react';
import logo from '../assets/riot.svg';
import Button from './Button';
const Login = () => {
  const [activeLogin, setActiveLogin] = useState(false);
  const [activePassword, setActivePassword] = useState(false);
  const [valueLogin, setValueLogin] = useState('');
  const [valuePassword, setValuePassword] = useState('');

  function classNamer(active: boolean, value: string) {
    if (active && value) {
      return 'active-span';
    }
  }

  return (
    <div className="login-container">
      <img src={logo} alt="Logo" />
      <div className="inputs">
        <h1>Fazer Login</h1>
        <div className="inputs-text">
          <label htmlFor="login">
            <span className={activeLogin || valueLogin ? 'active-span' : ''}>
              nome de usuário
            </span>
            <input
              type="text"
              id="login"
              onClick={() => setActiveLogin(true)}
              onBlur={() => setActiveLogin(false)}
              onChange={({ target }) => setValueLogin(target.value)}
            />
          </label>
          <label htmlFor="senha">
            <span
              className={activePassword || valuePassword ? 'active-span' : ''}
            >
              senha
            </span>
            <input
              type="password"
              id="senha"
              onClick={() => setActivePassword(true)}
              onBlur={() => setActivePassword(false)}
              onChange={({ target }) => setValuePassword(target.value)}
            />
          </label>
        </div>

        <div className="buttons">
          <Button variant="facebook" />
          <Button variant="google" />
          <Button variant="apple" />
          <Button variant="xbox" />
        </div>
        <label className="check">
          <input type="checkbox" id="login" />
          Manter login
        </label>
      </div>
      <button
        className={`login-button ${
          valueLogin && valuePassword ? 'active-button' : 'disabled'
        }`}
      >
        <Arrow />
      </button>
      <footer>
        <button>NÃO CONSEGUE INICIAR SESSÃO?</button>
        <span>vxx.x.x</span>
      </footer>
    </div>
  );
};

export default Login;
