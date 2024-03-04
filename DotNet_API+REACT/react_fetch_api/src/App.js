import {BrowserRouter,Routes,Route} from'react-router-dom'
import './App.css';
import Layout from './pages/Layout';
import LoginForm from './pages/Login/Login';
import GetAllProducts from './pages/Products/GetAllProducts';



function App() {
  return(
  <>
  <BrowserRouter>
  <Routes>
    <Route path='/' element={<Layout/>}/>
    <Route path='/Login' element={<LoginForm/>}/>
    <Route path='' element={<GetAllProducts/>}/>
  </Routes>
  </BrowserRouter>
  </>
  )
}

export default App;
