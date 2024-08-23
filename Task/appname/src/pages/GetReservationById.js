// src/pages/GetReservationsById.js

import React, { useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useNavigate } from 'react-router-dom';

const GetReservationsById = () => {
  const [reservationId, setReservationId] = useState('');
  const [fetchedReservation, setFetchedReservation] = useState(null);
  const [error, setError] = useState(null);
  const navigate = useNavigate();

  const handleFetchById = (event) => {
    event.preventDefault();
    setError(null);
    setFetchedReservation(null);

    axios.get(`http://localhost:5227/Api/Reservation/${reservationId}`)
      .then(response => {
        setFetchedReservation(response.data);
      })
      .catch(error => {
        setError(error.response?.data?.message || error.message || 'Error fetching reservation');
      });
  };
  const handleBack = () => {
    navigate(-1); // Goes back to the previous page
  };

  return (
    <div className="container mt-4">
      <h2 className="text-center mb-4">Fetch Reservation by ID</h2>
      <div className=" mt-4">
        <button className="btn btn-secondary" onClick={handleBack}>Back</button>
      </div>
      <form onSubmit={handleFetchById}>
        {error && <div className="alert alert-danger">{error}</div>}
        <div className="mb-3">
          <label htmlFor="reservationId" className="form-label">Reservation ID</label>
          <input
            type="text"
            id="reservationId"
            className="form-control"
            value={reservationId}
            onChange={(e) => setReservationId(e.target.value)}
            required
          />
        </div>
        <button type="submit" className="btn btn-info">Show Details</button>
      </form>

     
      {fetchedReservation && (
        <div className="mt-4">
          <h3>Reservation Details</h3>
          <table className="table table-striped table-bordered">
            <thead className="thead-dark">
              <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Start Location</th>
                <th>End Location</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>{fetchedReservation.id}</td>
                <td>{fetchedReservation.name}</td>
                <td>{fetchedReservation.startLocation}</td>
                <td>{fetchedReservation.endLocation}</td>
              </tr>
            </tbody>
          </table>
        </div>
      )}
    </div>
  );
};

export default GetReservationsById;