import React, {useState} from 'react';
import axios from "axios"

let endPoint = "http://localhost:3000"

export function Start() {
    const [user, setUser] = useState("");
    const [password, setPassword] = useState("");
    const [message, setMessage] = useState("");

    const onChangeUser = e => {
        setUser(e.target.value);
    }

    const onChangePassword = e => {
        setPassword(e.target.value);
    }

    const login = () => {
        axios
            .post(endPoint + "/login/", {user: user, password: password})
            .then(
                res => {
                    setMessage(res.data.message)
                },
                error => {
                    console.log(error);
                }
            )
    }


    return (
        <div className="App">
            <div>
            <label htmlFor={"user-input"}>user</label>
            <input id="user-input" onChange={e => onChangeUser(e)}/>
            </div>
            <div>
            <label htmlFor={"password-input"}>password</label>
            <input id="password-input" onChange={e => onChangePassword(e)}/>
            </div>
            <br></br>
            <div>
                <button onClick={() => login()}>Login</button>
            </div>
            <br></br>
            <div>
                <label >{message}</label>
            </div>

        </div>
    )
}
