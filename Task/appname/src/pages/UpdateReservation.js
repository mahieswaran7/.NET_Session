import React, { useEffect, useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useParams, useNavigate } from 'react-router-dom';

const UpdateReservation = () => {
  const { id } = useParams();
  const [reservation, setReservation] = useState(null);
  
  const [name, setName] = useState('');
  const [startLocation, setStartLocation] = useState('');
  const [endLocation, setEndLocation] = useState('');
  const [error, setError] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    axios.get(`http://localhost:5227/Api/Reservation/${id}`)
      .then(response => {
        setReservation(response.data);
        setName(response.data.name);
        setStartLocation(response.data.startLocation);
        setEndLocation(response.data.endLocation);
      })
      .catch(error => {
        console.error('Error fetching reservation:', error);
        setError(error.response?.data?.message || error.message || 'Error fetching reservation');
      });
  }, [id]);

  const handleUpdate = (event) => {
    event.preventDefault();
    setError(null);

    const data = new FormData();
    data.append('id', id);
    
    data.append('name', name);
    data.append('startLocation', startLocation);
    data.append('endLocation', endLocation);

    axios.put(`http://localhost:5227/Api/Reservation/`, data)
      .then(response => {
        alert('Reservation updated successfully!');
        navigate('/'); // Redirect to the home page or reservations page
      })
      .catch(error => {
        console.error('Error updating reservation:', error);
        setError(error.response?.data?.message || error.message || 'Error updating reservation');
      });
  };
  const handleBack = () => {
    navigate(-1); // Goes back to the previous page
  };

  if (error) return <p className="text-center text-danger">{error}</p>;

  return (
    <div className="container mt-4">
      <h2 className="text-center mb-4">Update Reservation</h2>
      <div className=" mt-4">
        <button className="btn btn-secondary" onClick={handleBack}>Back</button>
      </div>
      {reservation ? (
        <form onSubmit={handleUpdate}>
             <div className="mb-3">
    <label htmlFor="id">Id: </label>
    <input className="form-control" name="id" value={id} readOnly />
    </div>
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
          <button type="submit" className="btn btn-primary">Update</button>
        </form>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
};

export default UpdateReservation;