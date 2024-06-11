import {useEffect} from 'react'
import './App.css'

function App() {

    useEffect(() => {
        async function fetchData(){
            try{
                const response =  await fetch("api/Dummy");
                console.log(response);
                return await response.json();
            } catch(err){
                console.error(err);
            }  
        }
       fetchData().then(r => console.log(r));
    }, []);
  
    return (
    <>
     <h1>My React app</h1>
    </>
  )
}

export default App
