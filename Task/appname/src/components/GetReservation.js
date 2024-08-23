// src/components/GetReservation.js

import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';

const GetReservation = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const navigate = useNavigate();

  useEffect(() => {
    axios.get('http://localhost:5227/Api/Reservation')
      .then(response => {
        setData(response.data);
        setLoading(false);
      })
      .catch(error => {
        console.error('Error fetching reservations:', error);
        setError(error.response?.data?.message || error.message || 'Error fetching data');
        setLoading(false);
      });
  }, []);

  const handleBookTicketsClick = () => {
    navigate('/book-tickets');
  };

  const handleGetReservationByIdClick = () => {
    navigate('/reservation-details');
  };

  const handleUpdate = (id)=> {
    navigate(`/update-reservation/${id}`);
  };

  const handleDelete = (id)=> {
    if (window.confirm(`Are you sure you want to delete reservation ID: ${id}?`)) {
      axios.delete(`http://localhost:5227/Api/Reservation/${id}`)
        .then((response) => {
            console.log(response)
          setData(data.filter(item => item.id !== id));
        })
        .catch(error => {
          console.error('Error deleting reservation:', error);
          setError(error.response?.data?.message || error.message || 'Error deleting data');
        });
    }
  };

  if (loading) return <p className="text-center">Loading...</p>;
  if (error) return <p className="text-center text-danger">{error}</p>;

  if (!data || (Array.isArray(data) && data.length === 0)) return <p className="text-center">No data available.</p>;

  return (
    <div className="container mt-4">
      <div className="mb-4 text-center">
        <button
          className="btn btn-primary me-2"
          onClick={handleBookTicketsClick}
        >
          Book Tickets
        </button>
        <button
          className="btn btn-info"
          onClick={handleGetReservationByIdClick}
        >
          Get Reservation by ID
        </button>
      </div>

      <table className="table table-striped table-bordered">
        <thead className="thead-dark">
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Start Location</th>
            <th>End Location</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {Array.isArray(data) && data.length > 0 ? (
            data.map(reservation => (
              <tr key={reservation.id}>
                <td>{reservation.id}</td>
                <td>{reservation.name}</td>
                <td>{reservation.startLocation}</td>
                <td>{reservation.endLocation}</td>
                <td>
                  <button
                    className="btn btn-warning btn-sm me-2"
                    onClick={() => handleUpdate(reservation.id)}
                  >
                    Update
                  </button>
                  <button
                    className="btn btn-danger btn-sm"
                    onClick={() => handleDelete(reservation.id)}
                  >
                    Delete
                  </button>
                </td>
              </tr>
            ))
          ) : (
            <tr>
              <td colSpan="5" className="text-center">No reservations found.</td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
};

export default GetReservation;