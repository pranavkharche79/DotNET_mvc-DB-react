
import './App.css';
import axios from 'axios';
import { useEffect, useState } from 'react';

function App() {

  const [data,setdata]= useState([]);
  const [but,setbut]=useState("");

  useEffect(()=>{
    getallproducts();
  },[])
  
  const getallproducts=()=>{
    setbut("");
    try {
      axios.get("http://localhost:5232/products").then((res)=>{
        setdata(res.data);
        console.log(res.data);
      }).catch(error=>{
        console.log(error);
      })
      
    } catch (error) {
      console.log("errror",error);
    }
  }

  const searchbyid=(id)=>{
    console.log(id);
    if(id==null){
      getallproducts();
      return;
    }
    try {
      axios.get(`http://localhost:5232/products/${id}`).then((res)=>{
        setdata([res.data]);
        console.log(res.data);
      }).catch(error=>{
        alert(error.response.data);
      })
      
    } catch (error) {
      console.log("errror",error);
    }
  }



  if(data.length>0){
    return (
      <div>
        <input type='number'  min="1" value={but} onChange={(e)=>{
          setbut(e.target.value);
          console.log(e.target.value);
        }}/>
        <button onClick={()=>searchbyid(but)}>Submit</button>
        <button onClick={getallproducts} >clear</button>
        {data.map((obj)=>{
          return(
          <>
          <p>{obj.productid}</p>
          <p>{obj.title}</p>
          <p>{obj.picture}</p>
          <p>{obj.description}</p>
          <p>{obj.unitprice}</p>
          </>
        )})}
      </div>
    )
  } 
  else{
    return(
      <p>You do not have data</p>
    )
  }

}

export default App;
