import Arrow from '../assets/arrow.svg';
import logo from '../assets/riot.svg';
import Button from './Button';
const Login = () => {
  return (
    <div className="login-container">
      <img src={logo} alt="Logo" />
      <div className="inputs">
        <h1>Fazer Login</h1>
        <div className="inputs-text">
          <input type="text" placeholder="NOME DE USUÁRIO" />
          <input type="password" placeholder="SENHA" />
        </div>

        <div className="buttons">
          <Button variant="facebook" />
          <Button variant="google" />
          <Button variant="apple" />
          <Button variant="xbox" />
        </div>
        <div className="check">
          <label>
            <input type="checkbox" id="login" />
            <span></span>
          </label>
          <p>Manter login</p>
        </div>
      </div>
      <button className="login-button">
        <img src={Arrow} alt="login" />
      </button>
      <footer>
        <button>NÃO CONSEGUE INICIAR SESSÃO?</button>
        <span>vxx.x.x</span>
      </footer>
    </div>
  );
};

export default Login;
