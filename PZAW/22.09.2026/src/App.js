import logo from './logo.svg';
import szesc from './obrazy/szescian.jpg';
import prosto from './obrazy/prostopadloscian.png';
import kula from './obrazy/kula.png';
import './App.css';

const bryly = [
{"id":0,"nazwa":"SZEŚCIAN","obraz":szesc,
  "wzory":[ {"wzorObjetosc":"objetosc: V = a ^ 3"}, {"wzorPole":"pole: P = 6a ^ 2"} ],
  "przyklad":[ {"wymiar1":"1. wymiar = 2"} ]
},
{"id":1,"nazwa":"PROSTOPADLOSCIAN","obraz":prosto,
  "wzory":[ {"wzorObjetosc":"objetosc: V = a * b * h"}, {"wzorPole":"pole: P = 2 * a * b + 2 * a * h + 2 * b * h"}
  ],
  "przyklad":[ {"wymiar1":"1. wymiar = 3"}, {"wymiar2":"1. wymiar = 4"}, {"wymiar3":"1. wymiar = 5"}
  ]
},
{"id":2,"nazwa":"KULA","obraz":kula,
  "wzory":[ {"wzorObjetosc":"objetosc: V = 4/3 * pi * r ^ 3"}, {"wzorPole":"pole: P = 4 * pi * r ^ 2"}
  ],
  "przyklad":[ {"wymiar1":"1. wymiar = 4"}
  ]
}
];
function App() {
  return (
    <div className="App">
      <header>
        <h1>Bryły</h1>
      </header>
      <table>
        <thead>
          <tr>
            <th>BRYŁA</th>
            <th>ILUSTRACJA</th>
            <th>WZORY</th>
            <th>PRZYKLAD</th>
          </tr>
        </thead>
        <tbody>
          {bryly.map((item, index)=>(
            <tr key={item.id}>
              <td><b><i>{item.nazwa}</i></b></td>
              <td><img src={item.obraz}/></td>
              <td>
                <div>{item.wzory[0].wzorObjetosc}</div>
                <div>{item.wzory[1].wzorPole}</div>
              </td> 
              <td>
                
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
