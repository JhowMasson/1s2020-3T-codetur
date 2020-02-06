import React from 'react';
import logo from '../../assets/img/logo.png';
import './style.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img id="logoPrincipal" src={logo}
        alt="Logo do CodeTur"/>
        <a
          target="_blank"
          rel="noopener noreferrer"
        >
          Vamo Imundiça
        </a>
      </header>
    </div>
  );
}

export default App;
