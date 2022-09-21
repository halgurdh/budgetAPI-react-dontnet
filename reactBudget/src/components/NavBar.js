import React from 'react'
import { useNavigate } from "react-router-dom";


export default function NavBar() {

    const navigate = useNavigate();

    const getExpenses = () => {
        navigate("/expenses");
    }

    const getIncome = () => {
        navigate("/income");
    }


    return (
        <div className="container">
            <div className="row">
                <div className="col">
                    <button onClick={getExpenses} className="btn btn-dark">Get Expenses</button>
                </div>
                <div className="col">
                    <button onClick={getIncome} className="btn btn-dark">Get Income</button>
                </div>
            </div>
        </div >
    )
}
