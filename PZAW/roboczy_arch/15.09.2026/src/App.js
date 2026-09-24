import zdj from './images.jpg';
import './App.css';

function Ciag() {
  let dlugosc = prompt("Podaj długośc ciągu: ");
  let iloczyn = 1;
  let wynik = "1";
  let pierwszy = 1;
  let drugi = 1;
  let nast = 1;

  for (let i = 1; i < dlugosc; i++) {
    wynik += " * " + nast;
    iloczyn *= nast;

    nast = pierwszy + drugi;

    pierwszy = drugi;
    
    drugi = nast;
  }

  return <p>Iloczyn pierwszych {dlugosc} elementów ciągu Fibonacciego:<br/>{wynik} = {iloczyn}</p>;
}


function App() {
  return (
    <div className="App">
      <h2>Obliczanie iloczynu n elementów ciągu Fibonacciego</h2>
      <img src={zdj} className='App' alt='zdjecie'/>
      <main>
        <h3>Ciąg Fibonacciego</h3>
        <Ciag/>
      </main>
    </div>
  );
}

export default App;
