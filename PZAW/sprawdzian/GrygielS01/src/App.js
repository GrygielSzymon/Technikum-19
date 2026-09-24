import kwadrat from './kwadrat.png';
import './App.css';

function Pole() {
  let dlugosc = prompt("Podaj długośc boku: ");
  if (dlugosc > 0) {
    let pole = dlugosc * dlugosc;
    return <p className='pWynik'>Pole kwadratu o boku {dlugosc} wynosi: {pole}</p>;
  }
  else{
    return <p>Długość boku nie może być mniejsza niż zero!</p>;
  }
  
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
      </header>
      <main>
        <img src={kwadrat} alt="kwadrat" />
        <h1>Witaj w świecie geometrii</h1>
        <Pole/>
      </main>
    </div>
  );
}

export default App;
