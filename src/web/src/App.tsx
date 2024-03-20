import './App.css';
import Home from './Pages/Home/Home';
import MyAccount from './Pages/MyAccount';
import MyOrder from './Pages/MyOrder';
import MyOrders from './Pages/MyOrders';
import NotFound from './Pages/NotFound';
import SignIn from './Pages/SignIn';

function App() {
  return(
    <>
    <div className='bg-gray-500'>Hello World</div>
    <div className= 'flex flex-col'>
      <Home/>
      <MyAccount/>
      <MyOrder/>
      <MyOrders/>
      <NotFound/>
      <SignIn/>
    </div>
    </>
  );
}


export default App;
