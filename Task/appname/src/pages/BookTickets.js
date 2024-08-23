import React, { useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useNavigate } from 'react-router-dom';

const BookTickets = () => {
  const [name, setName] = useState('');
  const [startLocation, setStartLocation] = useState('');
  const [endLocation, setEndLocation] = useState('');
  const [error, setError] = useState(null);
  const [success, setSuccess] = useState(null);
  const [reservation, setReservation] = useState(null);

  const navigate = useNavigate();

  const handleSubmit = (event) => {
    event.preventDefault();
    setError(null);
    setSuccess(null);

    const newReservation = {
      name,
      startLocation,
      endLocation
    };

    axios.post('http://localhost:5227/Api/Reservation', newReservation)
      .then(response => {
        setSuccess('Ticket booked successfully!');
        setReservation(response.data); // Set reservation details
        // Optionally, reset form fields
        setName('');
        setStartLocation('');
        setEndLocation('');
        // Navigate to the reservations page after booking
        // Uncomment the next line if you want to navigate
        // navigate('/reservations');
      })
      .catch(error => {
        setError(error.response?.data?.message || error.message || 'Error booking ticket');
      });
  };
  const handleBack = () => {
    navigate(-1); // Goes back to the previous page
  };
  return (
    <div className="container mt-4">
         
      <h2 className="text-center mb-4">Book Tickets</h2>
      <div className=" mt-4">
        <button className="btn btn-secondary" onClick={handleBack}>Back</button>
      </div>
      <form onSubmit={handleSubmit}>
        {error && <div className="alert alert-danger">{error}</div>}
        {success && <div className="alert alert-success">{success}</div>}
        <div className="mb-3">
          <label htmlFor="name" className="form-label">Name</label>
          <input
            type="text"
            id="name"
            className="form-control"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="startLocation" className="form-label">Start Location</label>
          <input
            type="text"
            id="startLocation"
            className="form-control"
            value={startLocation}
            onChange={(e) => setStartLocation(e.target.value)}
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="endLocation" className="form-label">End Location</label>
          <input
            type="text"
            id="endLocation"
            className="form-control"
            value={endLocation}
            onChange={(e) => setEndLocation(e.target.value)}
            required
          />
        </div>
        <button type="submit" className="btn btn-primary">Book Now</button>
      </form>

    
      {reservation && (
        <div className="mt-4">
          <h3 className="text-center mb-3">Booked Reservation Details</h3>
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
                <td>{reservation.id}</td>
                <td>{reservation.name}</td>
                <td>{reservation.startLocation}</td>
                <td>{reservation.endLocation}</td>
              </tr>
            </tbody>
          </table>
        </div>
      )}
    </div>
  );
};

export default BookTickets;