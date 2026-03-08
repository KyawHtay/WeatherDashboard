import React, { useState } from "react";

function DefaultLocation({ onSetDefault }) {
  const [defaultCity, setDefaultCityInput] = useState(
    localStorage.getItem("defaultCity") || "London"
  );

  const handleSet = () => {
    if (!defaultCity.trim()) return;
    onSetDefault(defaultCity.trim());
  };

  return (
    <div className="default-location">
      <input
        type="text"
        placeholder="Set default city"
        value={defaultCity}
        onChange={(e) => setDefaultCityInput(e.target.value)}
      />
      <button onClick={handleSet}>Set Default</button>
    </div>
  );
}

export default DefaultLocation;