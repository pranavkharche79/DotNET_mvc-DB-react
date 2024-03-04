import React, { useState } from 'react';
import axios from 'axios';

const LoginForm = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');

  const sendCredentialsToAPI = async (uname, pwd) => {
    const credentials = new URLSearchParams();
    credentials.append('Username', uname);
    credentials.append('Password', pwd);
    console.log("Given uname and pass",credentials);
    try {
      const response = await axios.post('http://localhost:5171/Login', credentials);
      console.log('Credentials sent successfully!', response.data);
      // Handle the response here, such as setting tokens or updating UI based on success
    } catch (error) {
      console.error('Error sending credentials:', error);
      setError('Failed to log in. Please try again.');
      // Handle error scenarios or update UI with error message
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await sendCredentialsToAPI(username, password);
  };

  return (
    <div>
      
      <h2>Login</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="username">Username:</label>
          <input
            type="text"
            required
            id="username"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
          />
        </div>
        <div>
          <label htmlFor="password">Password:</label>
          <input
            type="password"
            required
            id="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
        </div>
        <button type="submit">Login</button>
      </form>
      {error && <p style={{ color: 'red' }}>{error}</p>}
    </div>
  );
};

export default LoginForm;